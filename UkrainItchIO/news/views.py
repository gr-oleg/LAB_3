from django.shortcuts import render
from .models import GameNews


def news_home(request):
    news = GameNews.objects.all()
    return render(request, 'news/news_home.html', {'news': news})
