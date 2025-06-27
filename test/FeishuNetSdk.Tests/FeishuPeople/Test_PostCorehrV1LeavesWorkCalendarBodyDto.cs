// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1LeavesWorkCalendarBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取工作日历 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取工作日历 请求体
/// <para>接口ID：7408403062694100995</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LeavesWorkCalendarBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "wk_calendar_ids": [
        "7136914415957591596"
    ],
    "wk_calendar_id_gt": "7136914415957591596",
    "wk_option": {
        "count": false,
        "offset": 0,
        "limit": 20,
        "sort_options": [
            {
                "sort_field": "wk_id",
                "sort_order": 0,
                "sort_i18n": 1,
                "sort_by_strand_length": false,
                "sort_by_pinyin": false,
                "sort_by_enum_value_order": false
            }
        ]
    },
    "only_enable": true
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1LeavesWorkCalendarBodyDto>(json);
        Assert.IsNotNull(result);
    }
}