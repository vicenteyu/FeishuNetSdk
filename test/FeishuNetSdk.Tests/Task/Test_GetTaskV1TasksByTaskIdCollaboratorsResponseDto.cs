// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTaskV1TasksByTaskIdCollaboratorsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取执行者列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取执行者列表 响应体
/// <para>接口ID：6985127383322230786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-collaborator%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV1TasksByTaskIdCollaboratorsResponseDto : TestBase
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
                "id": "ou_99e1a581b36ecc4862cbfbce473f1234",
                "id_list": [
                    "ou_99e1a581b36ecc4862cbfbce473f3123"
                ]
            }
        ],
        "page_token": "「上次返回的page_token」",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV1TasksByTaskIdCollaboratorsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}