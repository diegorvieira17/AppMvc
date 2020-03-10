﻿using System;
using System.Threading.Tasks;
using vmt.Business.Models;

namespace vmt.Business.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}