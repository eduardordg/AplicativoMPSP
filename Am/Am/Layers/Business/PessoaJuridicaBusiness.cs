﻿using Am.Layers.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Layers.Business
{
    public class PessoaJuridicaBusiness
    {
        public PessoaJuridicaService getService()
        {
            PessoaJuridicaService service = new PessoaJuridicaService();

            return service;
        }

    }
}
