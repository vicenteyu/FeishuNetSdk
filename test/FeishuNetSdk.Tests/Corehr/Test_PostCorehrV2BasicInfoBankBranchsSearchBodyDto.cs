// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoBankBranchsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询支行信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询支行信息 请求体
/// <para>接口ID：7301516605753212931</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-bank/search-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank_branch%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoBankBranchsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "bank_id_list": [
        "MDBH00000080"
    ],
    "bank_branch_id_list": [
        "MDBK00061194"
    ],
    "bank_branch_name_list": [
        "招商银行北京分行"
    ],
    "code_list": [
        "308100005019"
    ],
    "status_list": [
        1
    ],
    "update_start_time": "2020-01-01 00:00:00",
    "update_end_time": "2024-01-01 00:00:00"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoBankBranchsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}