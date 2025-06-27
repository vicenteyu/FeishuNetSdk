// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1CollaborationRulesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增可搜可见规则 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 新增可搜可见规则 请求体
/// <para>接口ID：7442539768884723740</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1CollaborationRulesBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1CollaborationRulesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}