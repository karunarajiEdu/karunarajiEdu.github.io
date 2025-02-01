# Generated by Django 2.2 on 2023-04-26 23:49

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Pet',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=200)),
                ('animal_type', models.CharField(max_length=200)),
                ('difficulty', models.CharField(max_length=200)),
                ('pet_desc', models.CharField(max_length=500)),
                ('pet_image', models.CharField(default='https://animalmicrochips.co.uk/images/default_no_animal.jpg', max_length=500)),
            ],
        ),
    ]
