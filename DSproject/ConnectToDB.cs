using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class ConnectToDB
{
     private string  path,userName,Password;
	public ConnectToDB(string path,string userName,string password)
	{
        this.userName = userName;
        this.path = path;
        this.Password = password;

        //connect to DB
	}

    public void uplodeFileToDB (File file)
    {
        //uplode file to DB
    }

    public File downloadsFileFromDB (string fileName)
    {
        //download file from DB
    }

    public string searchFile (string fileName)
    {
        // find file by name
    }
}
