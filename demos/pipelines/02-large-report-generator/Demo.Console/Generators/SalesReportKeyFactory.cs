﻿namespace Demo.Console.Generators;

public static class SalesReportKeyFactory
{
    public static string Create(int companyId, DateTime startDate, DateTime endDate)
        => $"C://tmp/sales//{companyId}-{startDate:yyyyMMdd}-{endDate:yyyyMMdd}.csv";
}
