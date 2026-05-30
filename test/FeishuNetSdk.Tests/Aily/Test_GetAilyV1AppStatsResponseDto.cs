// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_GetAilyV1AppStatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询应用统计数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 查询应用统计数据 响应体
/// <para>接口ID：7644497349981572316</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/tenant-app_stat/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2ftenant-app_stat%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AppStatsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "app_7d2f9c4a1b3e8",
                "name": "智能客服助手",
                "avg_daily_active_user_num": 1256.89,
                "avg_daily_run_num": 8923.45,
                "avg_daily_credit_usage": 5678.23,
                "total_credit_usage": 170346.9,
                "owner": {
                    "id": "1787137372910676",
                    "name": "张三",
                    "tenant_id": "200001",
                    "lark_user_id": "7563596720278863891"
                },
                "app_created_at": "2024-01-15 14:30:00"
            }
        ],
        "page_token": "eyJwYWdlX251bWJlciI6MywiY29udGVudF9pZCI6IjE2OTg3Mjk2MDAifQ==",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AppStatsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}