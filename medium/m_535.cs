// https://leetcode.com/problems/encode-and-decode-tinyurl/
// 535. Encode and Decode TinyURL

public class Codec {

    string host;
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        host = longUrl.Split('/')[0];
        longUrl = string.Join("/", longUrl.Split('/').Skip(1));
        var valueBytes = Encoding.UTF8.GetBytes(longUrl);
        return Convert.ToBase64String(valueBytes);
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        var valueBytes = System.Convert.FromBase64String(shortUrl);
        return host + "/" + Encoding.UTF8.GetString(valueBytes);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));