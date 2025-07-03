# Atlega Payroll - Payroll Rulebook

This document contains all the tax tables, file specifications, and calculation logic for the Atlega Payroll system. It is the company's bible.

## Phase 0: Foundation & Research

### Deconstruct BURS Compliance

**Action:** Get the latest official PAYE tax tables from the BURS website or office.

**Status:** Done.

**Resident Individual Taxpayers (2024/2025)**

| Taxable Income (BWP) | Tax Rate |
| --- | --- |
| 0 – 84,000 | 5% of each Pula |
| 84,001 – 120,000 | 4,200 + 12.5% of the amount over 84,000 |
| 120,001 – 156,000 | 8,700 + 18.75% of the amount over 120,000 |
| 156,001 and over | 15,450 + 25% of the amount over 156,000 |

**Non-Resident Taxpayers**

Non-resident taxpayers are subject to the same tax rates as residents, but they do not receive the initial tax-free threshold. They are taxed at a rate of 15% on interest, royalties, and management fees, 10% on dividends, and 10% on entertainment fees for income sourced in Botswana.

**Action**: Find the technical specification for the BURS electronic submission file (e-file).

**Status**: Done.

**Key Information**

*   The approved file formats for electronic submission are **XML (Extensible Markup Language)** and **CSV (Comma-Separated Values)**.
*   The monthly PAYE return schedule is known as **ITW7A**.
*   A revised CSV template for the monthly PAYE return (ITW7A) was introduced and must be used for reporting from the January 2024 tax period onwards. This update was to accommodate changes from the Income Tax (Amendment) Act, 2024.
*   Employers who have made payments such as pension lump sums, gratuities, severance pay, or retrenchment packages from January 2024 are required to revise their monthly PAYE returns using the updated template.
*   The BURS website has a file format validator to check your CSV file for errors before submission.

### Deconstruct Pension Compliance

**Action**: Research the rules for the major pension funds, starting with the Botswana Public Officers Pension Fund (BPOPF) as a model.

**Status**: Done.

**BPOPF Contribution Percentages**

*   **Employee Contribution**: 5% of their salaries.
*   **Employer (Government) Contribution**: 15% of the employee's salary.
*   Members can also make additional voluntary contributions of up to 10% of their salary.

**Action**: Find the specification for the monthly remittance report/file required by these funds.

**Status**: Done.

While a specific file format was not found, a typical monthly remittance report includes:

**1. Remittance Form (Summary)**
*   Employer details
*   Reporting period
*   Total contributions (member, employer, AVC)
*   Total amount remitted

**2. Employer Report of Contributions (Detailed Breakdown)**

| Field | Description |
| :--- | :--- |
| **Employee ID/Omang** | Unique identifier for the employee. |
| **Employee Full Name** | The full name of the employee. |
| **Gross Pensionable Salary** | The employee's gross salary for the month, upon which contributions are calculated. |
| **Member Contribution** | The 5% contribution from the employee's salary. |
| **Employer Contribution** | The 15% contribution from the employer. |
| **Additional Voluntary Contribution (AVC)** | Any additional voluntary contributions made by the employee for the month. |
| **Total Contribution** | The sum of member, employer, and AVC contributions for the employee for the month. |

### Understand the Employment Act

**Action**: Read the basic clauses of the Botswana Employment Act related to pay, leave, and termination.

**Status**: Done.

**Key Provisions**

*   **Payment of Wages**: Must be paid regularly and on time. The Act prohibits unauthorized deductions and mandates equal pay for equal work.
*   **Leave Entitlements**:
    *   **Annual Leave**: Minimum 15 working days of paid annual leave after one year of continuous service.
    *   **Public Holidays**: Employees are entitled to paid leave on public holidays.
    *   **Sick Leave**: Minimum 14 working days of paid sick leave per year.
    *   **Maternity Leave**: 12 weeks of maternity leave for female employees.
*   **Termination of Employment**:
    *   **Notice Period**: Both employers and employees are required to give notice before terminating a contract.
    *   **Grounds for Termination**: An employer must have a valid and justifiable reason for dismissing an employee.
    *   **Severance Pay**: An employee who is dismissed for reasons other than misconduct is entitled to severance pay based on their length of service.

### Define the Target Customer Persona

**Action**: Create a detailed profile of your ideal first customer.

**Status**: Done.

**Name**: "Thabo, owner of a Gaborone-based construction company."

**Company Size**: 15 full-time employees.

**Current Process**: His wife does the payroll once a month using an Excel spreadsheet. It takes her two days.

**Biggest Pain**: Worries constantly if the BURS submission is correct. Hates the manual process of printing payslips.





