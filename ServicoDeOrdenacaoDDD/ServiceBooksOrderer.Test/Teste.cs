


//using System;
//using System.Data.Common;
//using System.Linq;
//using System.Linq.Expressions;

//public static class Helpers
//{
//    public static Func<T, T>

//    DynamicSelectGenerator<T>(string Fields = "")
//    {
//        string[] EntityFields;

//        if (Fields == "") 

//            typeof(T).GetProperties().Select(propertyInfo => propertyInfo.Name).ToArray();
        
//        else EntityFields = Fields.Split(',');

// Expression.Parameter(typeof(T), "o");

//       var xNew = Expression.New(typeof(T));

//      var bindings = EntityFields.Select(o => o.Trim()).Select(o => {
//            var mi = typeof(T).GetProperty(o);
//     = Expression.Property(DbParameter, mi);
//          return Expression.Bind(mi, xOriginal);
//        });
// var xInit = Expression.MemberInit(xNew, bindings);
//   var lambda = Expression.Lambda<Func<T, T>>(xInit, xParameter);
//       Func < System.Data, Data >
//            return lambda.Compile();
//    }
//}








































































