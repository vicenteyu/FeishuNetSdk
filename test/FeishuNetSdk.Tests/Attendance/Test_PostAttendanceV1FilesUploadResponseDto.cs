namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 上传用户人脸识别照片 响应体
/// <para>接口ID：7044467124773765121</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2ffile%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1FilesUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file": {
            "file_id": "6b30e7636a38861bbe02869c726a4612"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1FilesUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}