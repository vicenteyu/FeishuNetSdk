// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV1TasksByTaskIdFollowersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增关注人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 新增关注人 请求体
/// <para>接口ID：6985127383322181634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-follower%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdFollowersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "ou_99e1a581b36ecc4862cbfbce473f3123",
    "id_list": [
        "ou_99e1a581b36ecc4862cbfbce473f3123"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdFollowersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}