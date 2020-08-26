# The WPF Cookbook

[toc]

## BindingGroup

Binding Groups contain a collection of bindings and validation rules that are used to validate an object.

Consider this: you have a WPF form, and in it there is a field that want users to enter an IP Address. How do we make sure that the user enters a string that the can be parse as one?

Should we make a `IPAddress.TryParse()` exception to capture that error string input? Well, sure, that is one way to do it. But consider the inconvenience:

-  It is not inherently responsive. You need to write your own Events and EventArgs classes to capture that error. 
- What about other types of Validation, not just for IP address? We need multiple different implementation for each validation rule.

The WPF carries with it the inherent feature called `BindingGroup` and `ValidationRule` that can help us manage and better implement different validation rules, and also provides interfaces for controls to render different appearances based on the status of the validation.

Binding Group also solves the problem of overarching validations. For example, we don't need to create logic for a class or event handler to check for all items being valid and then allow the submission, we can use the binding group to do that.

### Problem

You want to write validation rules for your form, which, depending on user's input, render different appearances.

For the Application (or, current input page), we want to validate all and then allow submission.

### Preparation

Step 1: Create a new project in Visual Studio for WPF .net framework.

Step 2: Convert the project into MVVM structure

- Delete MainWindow.xaml
- Create folder Models, ViewModels, Views
- Create new Window class file under Views named "MainWindow.xaml"
- Modify the App.xaml file:

```xaml
<Application
             ...
             StartupUri="Views/MainWindow.xaml">
</Application>
```

Step 3:  In the Views/MainWindow.xaml file, write structure for the application:

```xaml
<StackPanel>
    <StackPanel.Resources>
        <Style TargetType="HeaderedContentControl">
        </Style>
        <Style TargetType="Button"></Style>
    </StackPanel.Resources>
    <StackPanel.BindingGroup>
        <BindingGroup>
        </BindingGroup>
    </StackPanel.BindingGroup>
    <TextBlock Text="Enter Machine Information"/>
    <HeaderedContentControl Header="Host Name">
    	<TextBox Name="hostnameField" Width="150">
        </TextBox>
    </HeaderedContentControl>
    <HeaderedContentControl Header="Domain">
    	<TextBox Name="domainField" Width="150">
        </TextBox>
    </HeaderedContentControl>
    <HeaderedContentControl Header="IPv4 Address">
    	<TextBox Name="ipv4Field" Width="150">
        </TextBox>
    </HeaderedContentControl>
    <HeaderedContentControl Header="IPv6 Address">
    	<TextBox Name="ipv6Field" Width="150">
        </TextBox>
    </HeaderedContentControl>
    <StackPanel Orientation="Horizontal">
    	<Button IsDefault="True" Click="Submit_Clicked">_Submit</Button>
        <Button IsCancel="True" Click="Cancel_Clicked">_Cancel</Button>
    </StackPanel>
    <TextBlock Text="Machine Information Displayed"/>
    <HeaderedContentControl Header="Host Name">
    	<TextBlock Width="150">
        </TextBlock>
    </HeaderedContentControl>
    <HeaderedContentControl Header="Domain">
    	<TextBlock Width="150">
        </TextBlock>
    </HeaderedContentControl>
    <HeaderedContentControl Header="IPv4 Address">
    	<TextBlock Width="150">
        </TextBlock>
    </HeaderedContentControl>
    <HeaderedContentControl Header="IPv6 Address">
    	<TextBlock Width="150">
        </TextBlock>
    </HeaderedContentControl>
</StackPanel>
```

Step 4: Populate Styles for each control Element inside the stack panel

```xaml
    <StackPanel Name="stackPanel1" Margin="10" Width="250"
                Loaded="stackPanel1_Loaded"
                Validation.Error="ItemError">
        <StackPanel.Resources>
            <Style TargetType="HeaderedContentControl">
                <Setter Property="Margin" Value="2"/>
                <Setter Property="Focusable" Value="False"/>
                <Setter Property="Template">
                    <Setter.Value>
                        <ControlTemplate TargetType="HeaderedContentControl">
                            <DockPanel LastChildFill="False">
                                <ContentPresenter ContentSource="Header" DockPanel.Dock="Left" Focusable="False" VerticalAlignment="Center" />
                                <ContentPresenter ContentSource="Content" 
Margin="5 0 0 0" DockPanel.Dock="Right" VerticalAlignment="Center" />
                                
                            </DockPanel>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
                
            </Style>
            <Style TargetType="Button">
                <Setter Property="Width" Value="100"/>
                <Setter Property="Margin" Value="10 15 15 15"/>
            </Style>
            ...
        </StackPanel.Resources>
```

So far the XAML file presents basic UI for the application and gives the application a structured and neat look:

![groupbinding-step4-1](./images/groupbinding-step4-1.jpg)



### Solution

### There's More

### References:

Microsoft. (2018, April 30). *BindingGroup Class (System.Windows.Data) | Microsoft Docs*. Retrieved from Microsoft Documentation: https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.bindinggroup?view=netcore-3.1

 