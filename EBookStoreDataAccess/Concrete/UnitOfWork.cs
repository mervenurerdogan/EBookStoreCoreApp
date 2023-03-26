using EBookStoreDataAccess.Abstract;
using EBookStoreDataAccess.Concrete.Context;
using EBookStoreDataAccess.Concrete.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EBookStoreContext _context;

        private EfAuthorRepository _authorRepository;
        private EfBookRepository _bookRepository;
        private EfBookAuthorRepository _bookAuthorRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCityRepository _cityRepository;
        private EfCommentRepository _commentRepository;
        private EfOrderListRepository _orderListRepository;
        private EfOrderRepository _orderRepository;
        private EfPublisherHomeRepository _publisherHomeRepository;
        private EfUserRepository _userRepository;
        private EfRoleRepository _roleRepository;

        public UnitOfWork(EBookStoreContext context)
        {
            _context=context;
        }

        public IAuthorRepository Authors => _authorRepository ?? new EfAuthorRepository(_context);

        public IBookRepository Books => _bookRepository ?? new EfBookRepository(_context);

        public IBookAuthorRepository BookAuthors => _bookAuthorRepository ?? new EfBookAuthorRepository(_context);
        //burada Book istendiğinde Add metodu vs istedindiğinde eğer _bookrepository varsa işlem dönüyor ama yoksa null ise ?? ile newleyerek yeni repo oluşuturuyor
        //?? operatörü eğer null ise alternatif üretiyor
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public ICityRepository Cities =>_cityRepository ?? new EfCityRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IOrderListRepository OrderLists => _orderListRepository ?? new EfOrderListRepository(_context);

        public IOrderRepository Orders => _orderRepository ?? new EfOrderRepository(_context);

        public IPublisherHomeRepository PublisherHomes => _publisherHomeRepository ?? new EfPublisherHomeRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository (_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

       

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
