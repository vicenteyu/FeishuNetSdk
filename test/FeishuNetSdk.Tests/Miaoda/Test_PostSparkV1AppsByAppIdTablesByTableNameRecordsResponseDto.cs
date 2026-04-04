// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 向数据表中添加或更新记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 向数据表中添加或更新记录 响应体
/// <para>接口ID：7620858064161770703</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/post_table_records</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fpost_table_records</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "record_ids": [
            "1cbb280d-fc3d-4dca-9db5-adb14c4c83ec"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdTablesByTableNameRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}