// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索妙记 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 搜索妙记 请求体
/// <para>接口ID：7633638495471881156</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "周会",
    "filter": {
        "owner_ids": [
            "ou-7890123456abcdef"
        ],
        "participant_ids": [
            "ou-7890123456abcdef"
        ],
        "create_time": {
            "start_time": "2026-03-21T16:15:30+08:00",
            "end_time": "2026-03-21T16:15:30+08:00"
        }
    },
    "sorter": "create_time_desc"
}
""";
        var result = Deserialize<FeishuNetSdk.Minutes.PostMinutesV1MinutesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}