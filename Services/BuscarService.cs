using Desafio.Data;
using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;


public class SearchService : ISearchService
{
    private readonly ApplicationDbContext _dbContext;

    public SearchService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Registro> Search(DateTime dateFrom, DateTime dateTo, string descriptionFilter, string businessLocation)
    {
        var query = _dbContext.Registros.AsQueryable();

        if (!string.IsNullOrEmpty(descriptionFilter))
        {
            query = query.Where(r => r.Nombre.Contains(descriptionFilter) || r.Apellido.Contains(descriptionFilter));
        }

        if (!string.IsNullOrEmpty(businessLocation))
        {
            query = query.Where(r => r.BusinessLocation == businessLocation);
        }

        query = query.Where(r => r.Date >= dateFrom && r.Date <= dateTo);

        return query.ToList();
    }
}
