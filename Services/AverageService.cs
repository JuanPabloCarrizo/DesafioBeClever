using Desafio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Desafio.Models;

public class AverageService : IAverageService
{
    private readonly ApplicationDbContext _dbContext;

    public AverageService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Dictionary<string, Dictionary<string, double>> GetAverages(DateTime dateFrom, DateTime dateTo)
    {
        var result = new Dictionary<string, Dictionary<string, double>>();

        var registros = _dbContext.Registros
            .Where(r => r.Date >= dateFrom && r.Date <= dateTo)
            .ToList();

        var groupedByLocation = registros.GroupBy(r => r.BusinessLocation);

        foreach (var locationGroup in groupedByLocation)
        {
            var location = locationGroup.Key;
            var maleCount = locationGroup.Count(r => r.Genero == "Hombre");
            var femaleCount = locationGroup.Count(r => r.Genero == "Mujer");

            var maleMonthlyAverage = maleCount / ((dateTo.Year - dateFrom.Year) * 12 + dateTo.Month - dateFrom.Month + 1);
            var femaleMonthlyAverage = femaleCount / ((dateTo.Year - dateFrom.Year) * 12 + dateTo.Month - dateFrom.Month + 1);

            result[location] = new Dictionary<string, double>
            {
                { "Hombres", maleMonthlyAverage },
                { "Mujeres", femaleMonthlyAverage }
            };
        }

        return result;
    }
}
