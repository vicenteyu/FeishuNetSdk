// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2TasklistsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建清单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建清单 请求体
/// <para>接口ID：7255580838154469404</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasklistsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "年会工作任务清单",
    "members": [
        {
            "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
            "type": "user",
            "role": "editor"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasklistsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}