from django.db import models


class GameNews(models.Model):
    title = models.CharField('Титулка', max_length=100)
    anons = models.CharField('Intro', max_length=250, default='Intro')
    img_url = models.TextField('ImgWeb')
    text = models.TextField('Основний текст')
    date = models.DateTimeField('Дата публікації')

    def __str__(self):
        return self.title

    class Meta:
        verbose_name = 'Новина'
        verbose_name_plural = 'Новини'
