using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudEntityFramework.Context
{   
    //Context = essa e uma classe q centraliza todas nossas informações em determinado  banco de dados. 
    // AgendaContext = Classe que vai acessar o banco de dados, usaremos para chamar a conexão com o banco
    public class AgendaContext : DbContext
    {
        // criando construtor especial para passar a conexão do banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {

        }

        // criando a propriedade q se refere a entidade Contato. Entidade e uma tabela e uma classe 
        public DbSet<Contato> Contatos{get; set;} // esta dentro de um dbset pq está sendo representado por um objeto e por uma tabela em nosso banco de dados
        
        
    }
}