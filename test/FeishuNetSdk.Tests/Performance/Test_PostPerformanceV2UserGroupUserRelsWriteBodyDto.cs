// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2UserGroupUserRelsWriteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新人员组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 更新人员组成员 请求体
/// <para>接口ID：7381506957100875778</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/user_group_user_rel/write</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fuser_group_user_rel%2fwrite</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2UserGroupUserRelsWriteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "group_id": "ABCDEFG",
    "scope_visible_setting": 1,
    "user_ids": [
        "ou_fab1210511b6d2f990ba3b4e2e0dbeef"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2UserGroupUserRelsWriteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}