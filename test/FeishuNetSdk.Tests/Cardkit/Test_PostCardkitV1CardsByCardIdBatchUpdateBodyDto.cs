// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCardkitV1CardsByCardIdBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量更新卡片实体 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 批量更新卡片实体 请求体
/// <para>接口ID：7397253002364633091</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsByCardIdBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "uuid": "191857678434",
    "sequence": 1,
    "actions": "[{\"action\":\"partial_update_setting\",\"params\":{\"config\":{\"streaming_mode\":true},\"card_link\":{\"url\":\"https://open.feishu.cn\"}}},{\"action\":\"add_elements\",\"params\":{\"type\":\"insert_before\",\"target_element_id\":\"text_1\",\"elements\":[{\"tag\":\"markdown\",\"id\":\"md_1\",\"content\":\"示例文本\"}]}},{\"action\":\"delete_elements\",\"params\":{\"element_ids\":[\"text_1\",\"text_2\"]}},{\"action\":\"partial_update_element\",\"params\":{\"element_id\":\"target_element\",\"partial_element\":{\"content\":\"更新后的组件文本\"}}},{\"action\":\"update_element\",\"params\":{\"element_id\":\"target_element\",\"element\":{\"tag\":\"markdown\",\"id\":\"md_1\",\"content\":\"普通文本\"}}}]"
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PostCardkitV1CardsByCardIdBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}