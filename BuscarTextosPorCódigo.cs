﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.Plugin;
using Digi21.Utilities;

namespace DigiNG.Search
{
    [LocalizableSearcher(typeof(MyResource), "BuscarTextosPorCódigoName")]
    public class BuscarTextosPorCódigo : ISearcher
    {
        private readonly FormularioPideCódigo form = new FormularioPideCódigo();
        public Form Form => form;

        public IEnumerable<Entity> Search(IEnumerable<Entity> entities)
        {
            return entities.OfType<ReadOnlyText>().QueTenganElCódigoConComodín(form.Código);
        }
    }
}
