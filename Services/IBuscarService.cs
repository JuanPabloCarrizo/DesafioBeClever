using Desafio.Models;
using System;
using System.Collections.Generic;
using Desafio.Models;

public interface ISearchService
{
    IEnumerable<Registro> Search(DateTime dateFrom, DateTime dateTo, string descriptionFilter, string businessLocation);
}
