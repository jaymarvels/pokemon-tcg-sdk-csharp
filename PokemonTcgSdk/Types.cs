﻿using PokemonTcgSdk.Helpers;
using PokemonTcgSdk.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace PokemonTcgSdk
{
    public class Types
    {
        /// <summary>
        /// Get all of the Types.
        /// </summary>
        /// <returns></returns>
        public static List<string> All()
        {
            return QueryBuilder.GetTypes();
        }
    }
}
