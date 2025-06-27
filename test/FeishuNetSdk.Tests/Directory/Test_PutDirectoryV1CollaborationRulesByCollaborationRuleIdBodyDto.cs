// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutDirectoryV1CollaborationRulesByCollaborationRuleIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新可搜可见规则 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 更新可搜可见规则 请求体
/// <para>接口ID：7442539768884559900</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutDirectoryV1CollaborationRulesByCollaborationRuleIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "subjects": {
        "open_user_ids": [
            "od-112121"
        ],
        "open_department_ids": [
            "od-12121212"
        ],
        "open_group_ids": [
            "od-12121"
        ]
    },
    "objects": {
        "open_user_ids": [
            "od-112121"
        ],
        "open_department_ids": [
            "od-12121212"
        ],
        "open_group_ids": [
            "od-12121"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PutDirectoryV1CollaborationRulesByCollaborationRuleIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}