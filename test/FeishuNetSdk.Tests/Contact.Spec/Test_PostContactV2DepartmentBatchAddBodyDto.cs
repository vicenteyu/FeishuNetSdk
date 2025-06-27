// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV2DepartmentBatchAddBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量新增部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact.Spec;

/// <summary>
/// 测试 批量新增部门 请求体
/// <para>接口ID：6907569524101021697</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-departments</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDOwUjLzgDM14yM4ATN</para>
/// </summary>
[TestClass]
public class Test_PostContactV2DepartmentBatchAddBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "departments": [
        {
            "id": "custom_1",
            "name": "custom_1",
            "parent_id": "custom_2",
            "leader_user_id": "id_zhangsan",
            "leader_open_id": "ou_123456787999b8329abcdef00f7ce93c",
            "create_group_chat": true
        },
        {
            "id": "custom_2",
            "name": "custom_2",
            "parent_id": "0"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.Spec.PostContactV2DepartmentBatchAddBodyDto>(json);
        Assert.IsNotNull(result);
    }
}