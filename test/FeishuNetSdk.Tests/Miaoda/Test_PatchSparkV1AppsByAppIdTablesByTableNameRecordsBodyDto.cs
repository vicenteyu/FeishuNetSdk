// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_PatchSparkV1AppsByAppIdTablesByTableNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 按条件更新数据表中的记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 按条件更新数据表中的记录 请求体
/// <para>接口ID：7620858064161787087</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/patch_table_records</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fpatch_table_records</para>
/// </summary>
[TestClass]
public class Test_PatchSparkV1AppsByAppIdTablesByTableNameRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "record": "{\"age\":10}"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PatchSparkV1AppsByAppIdTablesByTableNameRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}