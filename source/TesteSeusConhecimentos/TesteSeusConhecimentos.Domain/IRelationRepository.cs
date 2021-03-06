﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteSeusConhecimentos.Entities;

namespace TesteSeusConhecimentos.Domain
{
    public interface IRelationRepository
    {
        IList<Relation> GetAll();
        Relation GetById(int id);
        void Delete(int id);
        /// <summary>
        /// Cria ou altera as informações do relacionamento
        /// </summary>
        /// <param name="Relation"></param>
        void Save(Relation user);
    }
}
