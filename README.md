# SecureNote
###### *created by Christian Vigil*
###### *CS-499-T4206 Computer Science Capstone 21EW4* 

### **Why create an application that creates notes?**

This idea come to fruition after my IPhone was stolen. In the old days before the age of technology, it was commong to keep a journal with a list of phone numbers, 
passwords, emails, addresses, etc. with any and all information for safe keeping. At the time, this was the best way to keep your data safe, but then came the age of cellphones. With the mobile technology skyrocketing, it was soon a normal practice to keep all sensitive data on your mobile device for quick and reliable documenting. This is one of the most unsafe practices as mobile phone theft has become more common but this is where my application shines. SecureNote has the ability to receive a note without displaying the contents and saving it in the database. 

### **How does it work?**

SecureNote is a low weight application that serves one purpose. To keep passwords, emails, security questions, etc. safe in the event that your phone is stolen. Simply sign in, select the Add button and enter your information. After you select the Save button the applicaton will create a unique ID and store your information in a cloud based database.

### **How do I download the application?**

Currently SecureNote has yet to gone live on the Apple Appstore. The only way to download the application is to send me an email to christian_vgl@yahoo.com for an invite to your email. SecureNote is not finished for the reason listed below. An alternative is to download my project and upload to your own IDE for editing purposes or enhancements.

### **How do I install SecureNote using emailed invitation?**
1. Open email received from App Center Team
2. Select Install
3. Sign-in to one of the option given to you by install.appcenter.ms
4. AppCenter will verify your device and if it is not found then you will need to register the device. As this application is IPhone only(at the moment) you will need to open your Settings app > Profile and accept the prompts given.
5. Once your device is registered the App Center will ask you to Install, select Yes
6. Exit the App Store browser and find the SecureNote app on your home screens

If you receive error messages advising that there is an issue with the installation please try again in five minutes. I have attempted to troubleshoot this issue but the App Center is on and off with when and where it installs applications. 

### **How do I download SecureNote for editing or to enhance the application?**
1. Download all the contents in the Master branch
2. Use Visual Studio Code(perferably) or any XAML enabled IDE
3. Install a Virutal Android and iOS environemtn
4. Select the Play button and watch the application start 

### **Current issues/bugs**
1. After signing in for the first time the application does not unauthenticate you. This causes a security issue as the user is logged in 100% of the time without being timed out or automatically signed out after exiting the application.
2. There is not a successfully notification after adding a note
3. .JPG integration for home page is not functioning
4. Back button for iOS is not functioning
5. Android SDK is corrupt
6. Android Gradle Plugin 4.1.0+ is not supported by AppCenter which means we will need to downgrade to older version for testing
