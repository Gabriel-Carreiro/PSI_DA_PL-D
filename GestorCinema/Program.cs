using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            // Verificar se o banco de dados já existe
            if (!DatabaseExists())
            {
                InformacoesForm informacoesFormIniciais = new InformacoesForm();
                var dialogResult = informacoesFormIniciais.ShowDialog();

                // Verificar se o usuário inseriu as informações e confirmou
                if (dialogResult == DialogResult.OK)
                {
                    // Inserir as informações iniciais
                    InsertInitialData();
                    Application.Run(new PrincipalForm());
                }
                else
                {
                    Application.Exit();
                }

            }
            else
            {
                Application.Run(new PrincipalForm());
            }
            bool DatabaseExists()
            {
                using (var context = new ApplicationContext())
                {
                    return context.Database.Exists();
                }
            }
            void InsertInitialData()
            {
                using (var context = new ApplicationContext())
                {
                    // Inserir informações iniciais na tabela "Categorias"
                    var categorias = new List<Categoria>
                    {
                        new Categoria { Nome = "Comédia", Estado = true },
                        new Categoria { Nome = "Sci-fi", Estado = true },
                        new Categoria { Nome = "Terror", Estado = true },
                        new Categoria { Nome = "Romance", Estado = true },
                        new Categoria { Nome = "Ação", Estado = true },
                        new Categoria { Nome = "Thriller", Estado = true },
                        new Categoria { Nome = "Drama", Estado = true },
                        new Categoria { Nome = "Mistério", Estado = true },
                        new Categoria { Nome = "Crime", Estado = true },
                        new Categoria { Nome = "Aventura", Estado = true },
                        new Categoria { Nome = "Fantasia", Estado = true },
                        new Categoria { Nome = "Animação", Estado = true }
                    };

                    context.Categorias.AddRange(categorias);
                    context.SaveChanges();
                }
            }
        }
       
    }
}
