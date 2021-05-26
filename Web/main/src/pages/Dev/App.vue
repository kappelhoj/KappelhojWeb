<template>
  <DefaultPage>
    <component :is="child_component"/>
  </DefaultPage>
</template>

<script>
import DefaultPage from '../../components/Structure/DefaultPage.vue'
import DevRoot from '../../components/Roots/DevRoot.vue'

export default{
  name: 'DevPage',
  components:{
    DefaultPage,
    DevRoot
  },
  data(){
    return {child_component: 'DevRoot'}
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
