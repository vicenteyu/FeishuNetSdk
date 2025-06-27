// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetWikiV2TasksByTaskIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取任务结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取任务结果 响应体
/// <para>接口ID：7041549010980634626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/task/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2ftask%2fget</para>
/// </summary>
[TestClass]
public class Test_GetWikiV2TasksByTaskIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "task": {
            "task_id": "7037044037068177428-075c9481e6a0007c1df689dfbe5b55a08b6b06f7",
            "move_result": [
                {
                    "node": {
                        "space_id": "6946843325487912356",
                        "node_token": "wikcnKQ1k3p******8Vabcef",
                        "obj_token": "doccnzAaOD******Wabcdef",
                        "obj_type": "doc",
                        "parent_node_token": "wikcnKQ1k3p******8Vabcef",
                        "node_type": "origin",
                        "origin_node_token": "wikcnKQ1k3p******8Vabcef",
                        "origin_space_id": "6946843325487912356",
                        "has_child": false,
                        "title": "标题",
                        "obj_create_time": "1642402428",
                        "obj_edit_time": "1642402428",
                        "node_create_time": "1642402428",
                        "creator": "ou_xxxxx",
                        "owner": "ou_xxxxx",
                        "node_creator": "ou_xxxxx"
                    },
                    "status": 0,
                    "status_msg": "success"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetWikiV2TasksByTaskIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}