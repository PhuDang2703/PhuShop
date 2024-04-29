using System.Linq.Expressions;


namespace Core.Specifications
{
    public interface ISpecifications<T>
    {
        //Delegate có kiểu trả về dùng khai báo <Func> còn ko có kiểu trả về void thì dùng <Action>, kiểu trả về là tham số cuối cùng, ở đây là boolean
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnable { get; }
    }
}