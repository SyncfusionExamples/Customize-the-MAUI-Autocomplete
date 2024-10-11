# Customize-the-MAUI-Autocomplete

This sample demonstrates how to customize the MAUI Autocomplete control within a .NET MAUI application. You'll also see how to display text in the input field, customize the clear icon, highlight the selected item and customize the items in the dropdown menu.

## Sample

```xaml
<autocomplete:SfAutocomplete ItemsSource="{Binding Employees}"
                             DisplayMemberPath="Name"
                             TextMemberPath="Name"
                             WidthRequest="280"
                             HeightRequest="50"
                             Placeholder="Select an employee">
    <autocomplete:SfAutocomplete.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <Grid Margin="{OnPlatform Default='0,2', Android='0,5'}"
                      VerticalOptions="Center"
                      HorizontalOptions="Center"
                      ColumnDefinitions="48,220">
                    <Image Grid.Column="0"
                           HorizontalOptions="Center"
                           VerticalOptions="Center"
                           Source="{Binding Profile}"/>
                    <StackLayout HorizontalOptions="Start"
                                 VerticalOptions="Center"
                                 Grid.Column="1"
                                 Margin="15,0,0,0">
                        <Label HorizontalTextAlignment="Start"
                               VerticalTextAlignment="Center"
                               FontSize="14"
                               Text="{Binding Name}"/>
                        <Label HorizontalOptions="Start"
                               VerticalTextAlignment="Center"
                               Opacity=".54"
                               FontSize="12"
                               Text="{Binding Designation}"/>
                    </StackLayout>
                </Grid>
            </ViewCell>
        </DataTemplate>
    </autocomplete:SfAutocomplete.ItemTemplate>
</autocomplete:SfAutocomplete>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
