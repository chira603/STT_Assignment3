import csv
from tabulate import tabulate

def analyze_lcom_values(csv_path, lcom_threshold=10.0):
    with open(csv_path, "r", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        high_lcom_classes = []
        for row in reader:
            lcom_vals = [
                float(row["LCOM1"]),
                float(row["LCOM2"]),
                float(row["LCOM3"]),
                float(row["LCOM4"]),
                float(row["LCOM5"]),
            ]
            avg_lcom = sum(lcom_vals) / len(lcom_vals)
            if avg_lcom > lcom_threshold:
                high_lcom_classes.append((row["Type Name"], *lcom_vals, row["YALCOM"], avg_lcom))

    # Analysis explanation
    print("Analysis of High-LCOM Classes")
    print("A high LCOM value suggests that a class has low cohesion, meaning its methods and fields are not closely related.\n"
          "This often indicates that the class is trying to handle multiple responsibilities, violating the Single Responsibility Principle.\n"
          "Consider performing functional decomposition to split the class into smaller, more cohesive classes.\n")

    # Table header and rows
    headers = ["Class Name", "LCOM1", "LCOM2", "LCOM3", "LCOM4", "LCOM5", "YALCOM", "(Avg)"]
    table = [[cls, f"{l1:.2f}", f"{l2:.2f}", f"{l3:.2f}", f"{l4:.2f}", f"{l5:.2f}", yalcom, f"({avg:.2f})"]
             for cls, l1, l2, l3, l4, l5, yalcom, avg in high_lcom_classes]

    print("LCOM Table (classes above threshold):")
    print(tabulate(table, headers=headers, tablefmt="grid"))

    # Output high-LCOM classes
    print("\nClasses with High LCOM Values:")
    for cls, *_ in high_lcom_classes:
        print(f"- {cls}")

if __name__ == "__main__":
    analyze_lcom_values("/home/chirag/Education/STT/lab9/results/TypeMetrics.csv")