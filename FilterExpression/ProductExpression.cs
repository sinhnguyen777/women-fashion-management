using System.Linq.Expressions;
using WomemFashionManagement.Models;

namespace WomemFashionManagement.FilterExpression
{
  public class ProductExpression
  {
    public static Expression<Func<Product, bool>> GetProductByCategory(int categoryId)
    {
      if (categoryId <= 0)
      {
        throw new ArgumentException("ID danh mục sản phẩm phải lớn hơn 0");
      }

      return p => p.CategoryId == categoryId;
    }
  }
}