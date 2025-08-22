// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_CorehrCommonDataIdUserMappingChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 用户ID映射变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 用户ID映射变更 事件体
/// <para>接口ID：7485189163967332371</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/common_data-id/events/user_mapping_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-id%2fevents%2fuser_mapping_changed</para>
/// </summary>
[TestClass]
public class Test_CorehrCommonDataIdUserMappingChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.common_data.id.user_mapping_changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "change_type": "insert",
        "id_transform_type": 1,
        "corehr_id": "6814523528021526024",
        "people_admin_id": "6894136542327997966",
        "feishu_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrCommonDataIdUserMappingChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}