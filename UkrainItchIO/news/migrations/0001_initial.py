# Generated by Django 4.2 on 2023-04-11 18:00

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='GameNews',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('title', models.CharField(max_length=100, verbose_name='Титулка')),
                ('anons', models.CharField(default='Intro', max_length=250, verbose_name='Intro')),
                ('img_url', models.TextField(verbose_name='ImgWeb')),
                ('text', models.TextField(verbose_name='Основний текст')),
                ('date', models.DateTimeField(verbose_name='Дата публікації')),
            ],
        ),
    ]
