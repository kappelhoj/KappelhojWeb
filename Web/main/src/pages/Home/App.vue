<template>
  <DefaultPage>
    <component :is="child_component"/>
  </DefaultPage>
</template>

<script>
import DefaultPage from '../../components/Structure/DefaultPage.vue'
import HomeRoot from '../../components/Roots/HomeRoot.vue'

export default{
  name: 'DevPage',
  components:{
    DefaultPage,
    HomeRoot
  },
  data(){
    return {child_component: 'HomeRoot'}
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>

