using SecretPerfume.Data;
using SecretPerfume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly SecrectPerfumeDbContext _context;
        private BranchRepository _branchRepo;
        private CategoryRepository _categoryRepo;
        private CommentRepository _commentRepo;
        private DiscountRepository _discountRepo;
        private DiscountTypeRepository _discountTypeRepo;
        private FeedbackRepository _feedbackRepo;
        private OrderRepository _orderRepo;
        private OrderDetailRepository _orderDetailRepo;
        private ProductRepository _productRepo;
        private ProductImageRepository _productImageRepo;
        private RatingRepository _ratingRepo;
        private RoleRepository _roleRepo;
        private SubCategoryRepository _subCategoryRepo;
        private UserRepository _userRepo;

        public UnitOfWork(SecrectPerfumeDbContext context)
        {
            _context = context;
        }
        public BranchRepository BranchRepo 
        {
            get
            {
                if (_branchRepo == null) {
                    _branchRepo = new BranchRepository(_context);
                }
                return _branchRepo;
            }
        }
        public CategoryRepository CategoryRepo 
        {
            get
            {
                if (_categoryRepo == null) {
                    _categoryRepo = new CategoryRepository(_context);
                }
                return _categoryRepo;
            }
        }
        public CommentRepository CommentRepo
        {
            get
            {
                if (_commentRepo == null) {
                    _commentRepo = new CommentRepository(_context);
                }
                return _commentRepo;
            }
        }
        public DiscountRepository DiscountRepo
        {
            get
            {
                if (_discountRepo == null)
                {
                    _discountRepo = new DiscountRepository(_context);
                }
                return _discountRepo;
            }
        }
        public DiscountTypeRepository DiscountTypeRepo
        {
            get
            {
                if (_discountTypeRepo == null)
                {
                    _discountTypeRepo = new DiscountTypeRepository(_context);
                }
                return _discountTypeRepo;
            }
        }
        public FeedbackRepository FeedbackRepo
        {
            get
            {
                if (_feedbackRepo == null)
                {
                    _feedbackRepo = new FeedbackRepository(_context);
                }
                return _feedbackRepo;
            }
        }
        public OrderRepository OrderRepo 
        {
            get
            {
                if (_orderRepo == null)
                {
                    _orderRepo = new OrderRepository(_context);
                }
                return _orderRepo;
            }
        }
        public OrderDetailRepository OrderDetailRepo
        {
            get
            {
                if (_orderDetailRepo == null)
                {
                    _orderDetailRepo = new OrderDetailRepository(_context);
                }
                return _orderDetailRepo;
            }
        }
        public ProductRepository ProductRepo
        {
            get
            {
                if (_productRepo == null)
                {
                    _productRepo = new ProductRepository(_context);
                }
                return _productRepo;
            }
        }
        public ProductImageRepository ProductImageRepo
        {
            get
            {
                if (_productImageRepo == null)
                {
                    _productImageRepo = new ProductImageRepository(_context);
                }
                return _productImageRepo;
            }
        }
        public RatingRepository RatingRepo
        {
            get
            {
                if (_ratingRepo == null)
                {
                    _ratingRepo = new RatingRepository(_context);
                }
                return _ratingRepo;
            }
        }
        public RoleRepository RoleRepo
        {
            get
            {
                if (_roleRepo == null)
                {
                    _roleRepo = new RoleRepository(_context);
                }
                return _roleRepo;
            }
        }
        public SubCategoryRepository SubCategoryRepo
        {
            get
            {
                if (_subCategoryRepo == null)
                {
                    _subCategoryRepo = new SubCategoryRepository(_context);
                }
                return _subCategoryRepo;
            }
        }
        public UserRepository UserRepo
        {
            get
            {
                if (_userRepo == null)
                {
                    _userRepo = new UserRepository(_context);
                }
                return _userRepo;
            }
        }
    }
}
