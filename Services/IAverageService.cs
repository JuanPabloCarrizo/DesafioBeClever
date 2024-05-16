using System;
using System.Collections.Generic;

public interface IAverageService
{
    Dictionary<string, Dictionary<string, double>> GetAverages(DateTime dateFrom, DateTime dateTo);
}
