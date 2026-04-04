// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdSqlCommandsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 执行 SQL 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 执行 SQL 请求体
/// <para>接口ID：7620858064161852623</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/sql_commands</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fsql_commands</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdSqlCommandsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "sql": "SELECT name FROM student"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdSqlCommandsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}