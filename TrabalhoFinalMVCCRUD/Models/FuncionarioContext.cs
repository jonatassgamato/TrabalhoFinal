﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoFinalMVCCRUD.Models
{
    public class FuncionarioContext:DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options):base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
