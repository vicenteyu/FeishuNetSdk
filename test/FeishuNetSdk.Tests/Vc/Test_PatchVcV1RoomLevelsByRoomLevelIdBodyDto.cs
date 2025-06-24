// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchVcV1RoomLevelsByRoomLevelIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新会议室层级 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 更新会议室层级 请求体
/// <para>接口ID：7160517356095995908</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1RoomLevelsByRoomLevelIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "测试层级",
    "parent_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
    "custom_group_id": "10000"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1RoomLevelsByRoomLevelIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}