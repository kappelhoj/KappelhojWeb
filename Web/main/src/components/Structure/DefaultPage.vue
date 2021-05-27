<template>
  <div class="page">
    <NavBar/>
    <slot></slot>
  </div>
</template>

<script>
import NavBar from '../../components/Structure/Navigation/NavBar.vue'

export default {
  name: 'DefaultPage',
    components: {
    NavBar
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .page{
    max-width: 1280px;
    flex-direction: column;
    display: flex;
    justify-content: center;
    text-align: center;
  }
</style>
