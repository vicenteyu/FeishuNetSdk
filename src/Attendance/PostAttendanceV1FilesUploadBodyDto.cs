using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 上传用户人脸识别照片 请求体
/// <para>上传文件并获取文件 ID，可用于“修改用户设置”接口中的 face_key 参数。</para>
/// <para>接口ID：7044467124773765121</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2ffile%2fupload</para>
/// </summary>
public record PostAttendanceV1FilesUploadBodyDto
{
}
