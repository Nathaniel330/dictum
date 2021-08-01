﻿using Dictum.Business.Abstract.Repositories;
using Dictum.Business.Services;
using Dictum.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Dictum.Api.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IQuoteRepository, QuoteRepository>();
            services.AddTransient<ILanguageRepository, LanguageRepository>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();

            services.AddSingleton<QuoteService>();
            services.AddSingleton<LanguageService>();
            services.AddSingleton<AuthorService>();
            services.AddSingleton<StatisticsService>();
        }
    }
}