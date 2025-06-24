// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV1TasksByTaskIdCollaboratorsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增执行者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 新增执行者 请求体
/// <para>接口ID：6985127383322198018</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-collaborator%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdCollaboratorsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "ou_99e1a581b36ecc4862cbfbce473f1234",
    "id_list": [
        "ou_99e1a581b36ecc4862cbfbce473f3123"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdCollaboratorsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}