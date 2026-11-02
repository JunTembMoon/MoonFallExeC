using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Potassium.DataModels;

namespace Potassium.Services;

public static class AuthService
{
    private static UserSession? _session;

    public static bool IsAuthenticated => _session != null;

    public static UserSession? Session => _session;

    /// <summary>
    /// 本地账号验证 - 从 acc.txt 读取账号密码
    /// 格式: 每行一个，2行一组（第一行账号，第二行密码）
    /// </summary>
    public static Task<string> Login(string username, string password)
    {
        // acc.txt 路径 - 在 exe 同目录下
        string accPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "acc.txt");

        if (!File.Exists(accPath))
        {
            return Task.FromException<string>(new Exception("acc.txt 文件不存在！无法登录。"));
        }

        string[] lines = File.ReadAllLines(accPath);

        // 2行一组：第一行账号，第二行密码
        for (int i = 0; i + 1 < lines.Length; i += 2)
        {
            string acc = lines[i].Trim();
            string pass = lines[i + 1].Trim();

            if (acc == username && pass == password)
            {
                // 验证成功，创建会话
                _session = new UserSession
                {
                    Username = username,
                    Jwt = GenerateLocalToken(username),
                    ExpiresAt = DateTime.Now.AddDays(30)
                };

                SaveSession(_session.Jwt);
                return Task.FromResult(_session.Jwt);
            }
        }

        return Task.FromException<string>(new Exception("账号或密码错误！"));
    }

    /// <summary>
    /// 生成本地 token（不连接远程 API）
    /// </summary>
    private static string GenerateLocalToken(string username)
    {
        byte[] bytes = Encoding.UTF8.GetBytes($"{username}:{DateTime.Now:yyyyMMddHHmmss}:potassium_local");
        return Convert.ToBase64String(bytes);
    }

    /// <summary>
    /// 保存会话到 bin/user.bin
    /// </summary>
    public static void SaveSession(string jwt)
    {
        try
        {
            string binDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            Directory.CreateDirectory(binDir);
            string userFile = Path.Combine(binDir, "user.bin");
            File.WriteAllText(userFile, jwt);
        }
        catch
        {
        }
    }

    /// <summary>
    /// 从 bin/user.bin 加载会话
    /// </summary>
    public static bool LoadSession()
    {
        try
        {
            string userFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "user.bin");
            if (!File.Exists(userFile)) return false;

            string jwt = File.ReadAllText(userFile);
            if (string.IsNullOrEmpty(jwt)) return false;

            _session = new UserSession
            {
                Username = "local",
                Jwt = jwt,
                ExpiresAt = DateTime.Now.AddDays(30)
            };
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 注销
    /// </summary>
    public static void Logout()
    {
        _session = null;
        try
        {
            string userFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "user.bin");
            if (File.Exists(userFile)) File.Delete(userFile);
        }
        catch
        {
        }
    }
}
