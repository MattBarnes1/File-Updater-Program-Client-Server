# File Updater Program
After the user logs in, the software creates hashes of a directory and sends those to a master server. The master server spawns threads and handles file access. It currently has a flaw where it bottlenecks based on the speed of the first connected client. This unfortunately could be exploited by a malicious user. A future implementation will use the C# parallel library to resolve this issue.
