// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建动态订阅 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建动态订阅 请求体
/// <para>接口ID：7288897051647000578</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist-activity_subscription/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "我的订阅",
    "subscribers": [
        {
            "id": "oc_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
            "type": "chat"
        }
    ],
    "include_keys": [
        100
    ],
    "disabled": false
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}