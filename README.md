---

# CoreDownloader

用于下载或是修复/校验Tool-P2PMode核心文件的工具，适用于MCZLFConnectToolP2PMode。🚀
⚠️ 仅供MCZLF Connect Tool 0.0.5及以上版本使用，0.0.4及更低版本暂无适配计划

## 功能简介
- ⚠️ 仅供MCZLF Connect Tool 0.0.5及以上版本使用
- ✅ 检查本地是否已存在目标文件（`main.exe` 或 `main32.exe`）。
- 🔒 通过MD5校验确保文件的完整性和安全性。
- 📥 根据系统架构（64位或32位）自动选择合适的文件进行下载。
- 📈 显示下载进度，并在完成后进行提示。

## 使用方法

### 环境要求

- 🌐 .NET Framework 4.5 或更高版本。

### 运行程序

1. 📁 克隆或下载Release到本地。
2. 📂 打开项目文件夹，使用Visual Studio或任何支持.NET Framework的IDE加载解决方案。
3. 🚀 编译并运行程序。
程序会自动检测系统架构并下载对应的文件到临时目录。

### 配置

- **MD5校验值**：在代码中，`fileMd5` 和 `fileMd532` 分别对应64位和32位文件的MD5校验值。如果文件更新，请相应地更新这些值。
- **下载链接**：在代码中，`url` 变量定义了文件的下载地址。如果链接失效，请替换为正确的链接。

## 代码结构

- 📄 `Program.cs`：主程序文件，包含核心逻辑。
- 🔨 `GetFileMD5Hash` 方法：用于计算文件的MD5校验值。
- 🔨 `DownloadProgressCallback` 方法：用于显示下载进度。
- 🔨 `Console.write` 方法：用于输出日志信息。

## 示例输出

```plaintext
当前下载器版本 0.0.1 MCZLFConnectToolP2PMode适用
下载进度: 50%
下载进度: 100%
下载完成
```

## 注意事项

- 🌐 确保网络环境可以访问下载链接。
- ✅ 如果下载失败，请检查网络状态或是联系管理员。
- ✏️ 如果需要对下载的文件进行进一步的处理（如解压、安装等），可以在代码中添加相应的逻辑。

## 贡献

欢迎提交问题、建议或代码改进。请遵循以下步骤：

1. 🍴 Fork此项目。
2. 🌿 创建一个新分支（`git checkout -b feature/your-feature`）。
3. 📋 提交你的更改（`git commit -am 'Add some feature'`）。
4. 🔃 推送到分支（`git push origin feature/your-feature`）。
5. 🔗 提交Pull Request。

## 许可证

本项目采用 📜 [MIT License](LICENSE) 许可证。你可以自由使用、修改和分发此代码。

---
## 遇到问题？
点击链接加入群聊【✨MCZLF Connect Tool交流群/M_Bot战双自动签丨禁广｜禁商｜】：https://qm.qq.com/q/5cV7gnSiDK
---

### 使用的Emoji

- ✅：表示检查或验证
- 🔒：表示安全或加密
- 📥：表示下载
- 📈：表示进度
- 🌐：表示网络或平台
- 📁：表示克隆
- 📂：表示打开文件夹
- 🚀：表示运行或启动
- 📄：表示文件
- 🔨：表示方法或功能
- ✏️：表示编辑
- 🍴：表示Fork
- 🌿：表示分支
- 📋：表示提交
- 🔃：表示推送
- 🔗：表示Pull Request
- 📜：表示许可证

---

该README由AI生成
