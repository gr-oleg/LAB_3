from django.urls import path
from . import views

urlpatterns = [
    path('', views.index, name='HomePage'),
    path('about', views.about, name='About'),
    path('login', views.login, name='LoginPage')
]
