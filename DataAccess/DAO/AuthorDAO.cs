using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AuthorDAO
    {
        public static void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public static List<Author> GetAllAuthors()
        {
            var listAuthors = new List<Author>();
            try
            {
                using (var context = new BookStoreDbContext())
                {
                    listAuthors=context.Authors.ToList();
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listAuthors;
        }

        public static Author GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public static void InsertAuthor(Author author)
        {
            try
            {
                using (var context = new BookStoreDbContext())
                {
                    context.Authors.Add(author);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
