// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_PostCorehrV2SignatureFilesTerminateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 终止电子签文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 终止电子签文件 响应体
/// <para>接口ID：7420421437193633795</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/terminate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fterminate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SignatureFilesTerminateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "total_count": 2,
        "success_count": 1,
        "fail_count": 1,
        "success_file_id_list": [
            "7410063506638112300"
        ],
        "fail_file_id_and_reasons": [
            {
                "signature_file_id": "7345403447803379731",
                "fail_reason": "文件状态不允许终止"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2SignatureFilesTerminateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}